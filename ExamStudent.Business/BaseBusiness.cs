using System;
using System.Collections.Generic;
using System.Text;

namespace ExamStudent.Business
{
   public class BaseBusiness
    {

        #region Declaration
        private bool _isTransactionRequired;
        public delegate void TransactionMethod();
        protected TransactionMethod operation;
        public BaseDataAccess m_Access;
        //private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Public Methods
        public BaseDataAccess Transaction
        {
            get { return m_Access; }
        }

        public TransactionMethod Operation
        {
            set { operation = value; }
        }

        public BaseBusiness()
        {
            m_Access = new BaseDataAccess();
        }

        public BaseBusiness(BaseDataAccess transaction)
        {
            m_Access = transaction;
        }


        public virtual void ExecuteOperation(bool isTransactionRequired)
        {
            try
            {
                _isTransactionRequired = isTransactionRequired;
                if (isTransactionRequired)
                {
                    this.BeginTransaction();
                    this.operation();
                    this.Commit();
                }
                else
                {
                    this.OpenConnection();
                    this.operation();
                    // this.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                RollBack();
                //CloseConnection();
                //log.StartMethod();
                if (ex.InnerException != null)
                    //log.Error("ExecuteOperation: " + ex.Message + ex.InnerException + ex.StackTrace.ToString());
                else
                    //log.Error("ExecuteDataSet: " + ex.Message + ex.StackTrace.ToString());
                //log.EndMethod();
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool Start(bool isTransactionRequired)
        {
            bool success = false;
            try
            {
                this.ExecuteOperation(isTransactionRequired);
                success = true;
            }
            catch (Exception ex)
            {
                log.StartMethod();
                if (ex.InnerException != null)
                    log.Error("Start: " + ex.Message + ex.InnerException + ex.StackTrace.ToString());
                else
                    log.Error("Start: " + ex.Message + ex.StackTrace.ToString());
                log.EndMethod();
                throw;
            }
            return (success);
        }
        #endregion

        #region Private Methods
        private void OpenConnection()
        {
            if (this.m_Access != null)
                this.m_Access.OpenConnection();
        }

        private void CloseConnection()
        {
            if (this.m_Access != null)
                this.m_Access.CloseConnection();
        }

        private void BeginTransaction()
        {
            if (this.m_Access != null)
                this.m_Access.BeginTransaction();
        }

        private void Commit()
        {
            if (this.m_Access != null)
                this.m_Access.CommitTransaction();
        }

        private void RollBack()
        {
            if (!_isTransactionRequired)
                return;

            if (this.m_Access != null)
                this.m_Access.RollbackTransaction();
        }
        #endregion


    }
}
