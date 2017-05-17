using System.Collections.Generic;
using LI.DataAccess;
using LI.PlainObject;

namespace LI.Service
{
    /// <summary>
    /// LoanService
    /// </summary>
    public class LoanService
    {
        private LoanDao _dao = new LoanDao();
        private static LoanService _instance = null;

        public static LoanService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoanService();
            }
            return _instance;
        }

        private LoanService() { }

        #region C,U,D methods

        public void InsertItem(Loan item)
        {
            _dao.InsertItem(item);
        }

        public void UpdateItem(Loan item)
        {
            _dao.UpdateItem(item);
        }

        public void DeleteItem(int id)
        {
            _dao.DeleteItem(id);
        }

        #endregion

        #region get methods

        public Loan GetItem(int id)
        {
            return _dao.GetItem(id);
        }

        public IList<Loan> GetItems()
        {
            return _dao.GetItems();
        }

        #endregion

        #region get count methods

        /// <summary>
        /// 取得所有"贷款"笔数
        /// </summary>
        /// <returns>"贷款"笔数</returns>
        public int GetCount()
        {
            return _dao.GetCount();   
        }

        #endregion
    }
}
