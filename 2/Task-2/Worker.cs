using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Worker
    {
        #region Private fields
        private String _name;
        private int _age;
        #endregion

        #region Public fields
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        #endregion

        #region Constructors
        public Worker(String Name, int Age)
        {
            _name = Name;
            _age = Age;
        }
        #endregion

        #region Methods
        public void DataInput()
        {
            Console.Write("Введите имя: ");
            _name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            _age = int.Parse(Console.ReadLine());
        }
        public override String ToString()
        {
            return ($"Имя: {Name}; Возраст: {Age}");
        }
        #endregion
    }
    class Personnal : Worker
    {
        #region Private fields
        private DateOnly _dateOfEmployment;
        #endregion

        #region Public fields
        public DateOnly DateOfEmployment
        {
            get { return _dateOfEmployment; }
            set { _dateOfEmployment = value; }
        }
        #endregion

        #region Constructors
        public Personnal(String Name, int Age, DateOnly DateOfEmployment) : base(Name, Age)
        {
            _dateOfEmployment = DateOfEmployment;
        }
        #endregion

        #region Methods
        public override String ToString()
        {
            return base.ToString() + $"; Дата приема на работу: {DateOfEmployment}";
        } 
        #endregion
    }
    class Engineer : Worker
    {
        #region Private fields
        private String _specialisation;
        #endregion

        #region Public fields 
        public String Specialisation
        {
            get { return _specialisation; }
            set { _specialisation = value; }
        }
        #endregion

        #region Constructor
        public Engineer(String Name, int Age, String Specialisation) : base(Name, Age)
        {
            _specialisation = Specialisation;
        }
        #endregion

        #region Methods
        public override String ToString()
        {
            return base.ToString() + $"; Специализация: {Specialisation}";
        }
        public void DataInput()
        {
            Console.Write("Введите имя: ");
            _specialisation = Console.ReadLine();
        }
        #endregion
    }
    class Administration : Worker
    {
        #region Private field
        private String _appointment;
        #endregion

        #region Public fields
        public String Appointment
        {
            get { return _appointment; }
            set { _appointment = value; }
        }
        #endregion

        #region Constructor
        public Administration(string Name, int Age, String Appointment) : base(Name, Age)
        {
            _appointment = Appointment;
        }
        #endregion

        #region Methods
        public override String ToString()
        {
            return base.ToString() + $"; Назначение: {Appointment}";
        }
        public void DataInput()
        {
            Console.Write("Введите имя: ");
            _appointment = Console.ReadLine();
        }
        #endregion
    }

}

