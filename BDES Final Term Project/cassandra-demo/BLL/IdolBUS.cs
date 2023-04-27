using System.Collections.Generic;
using cassandra_demo.DAL;
using cassandra_demo.Model;

namespace cassandra_demo.BLL
{
    internal class IdolBUS
    {
        private readonly IdolDAO _idolDAO;

        public IdolBUS()
        {
            _idolDAO = new IdolDAO();
        }

        public IEnumerable<Idol> GetAllIdol()
        {
            return _idolDAO.GetAllIdol();
        }

        public void InsertIdol(Idol idol)
        {
            _idolDAO.InsertIdol(idol);
        }

        public IEnumerable<Idol> SearchIdol(string key)
        {
            return _idolDAO.SearchIdol(key);
        }

        public void UpdateIdol(Idol idol)
        {
            _idolDAO.UpdateIdol(idol);
        }

        public void DeleteIdol(string key)
        {
            _idolDAO.DeleteIdol(key);
        }
    }
}