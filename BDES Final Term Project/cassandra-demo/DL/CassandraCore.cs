using System.Collections.Generic;
using System.Windows.Forms;
using Cassandra;
using Cassandra.Mapping;

namespace cassandra_demo.DL
{
    internal class CassandraCore
    {
        private readonly IMapper _mapper;
        private readonly ISession _session;

        public CassandraCore()
        {
            try
            {
                _session = Cluster.Builder().AddContactPoint(Constants.ContactPoint).Build()
                    .Connect(Constants.KeySpace);
            }
            catch (NoHostAvailableException)
            {
                MessageBox.Show(@"No host available!", @"Error!", MessageBoxButtons.OK);
            }

            _mapper = new Mapper(_session);
        }

        public IEnumerable<T> ExecuteLoadQuery<T>(string query)
        {
            return _mapper.Fetch<T>(query);
        }

        public void ExecuteNonQuery(string query)
        {
            _session.Execute(query);
        }
    }
}