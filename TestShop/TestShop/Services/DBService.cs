using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using TestShop.Model;

namespace TestShop.Services
{
    public class DBService
    {
        public static void Save(ВидТовара видТовара)
        {
            try
            {
                Configuration configuration = new Configuration();
                configuration.Configure();

                ISessionFactory factory = configuration.BuildSessionFactory();

                ISession session = factory.OpenSession();
                ITransaction transaction = session.BeginTransaction();

                session.SaveOrUpdate(видТовара);

                transaction.Commit();

                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
