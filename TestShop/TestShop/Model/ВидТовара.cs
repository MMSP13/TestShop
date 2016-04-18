using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Model
{
    public class ВидТовара
    {
        private long id;

        private string наименование;

        /// <summary>
        /// Уникальный идентификатор объекта
        /// </summary>
        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Наименование вида товара
        /// </summary>
        public virtual string Наименование
        {
            get { return наименование; }
            set { наименование = value; }
        }
    }
}
