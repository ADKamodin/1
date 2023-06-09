using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTRPOLR2
{
    /// <summary>
    ///Variant 13: https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit
    /// </summary>
    public class Корпус
    {
        public string Название { get; }
        public string Адрес { get; }
        public Сотрудник Комендант{ get; }
        public Организация Организация { get; }

        public Корпус(string название, string адрес, Сотрудник комендант, Организация организация)
        {
            Название = название;
            Адрес = адрес;
            Комендант = комендант;
            Организация = организация;
        }
    }
}