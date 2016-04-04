using System;

namespace Phonebook
{
    public struct Person
    {
        public Person(string name, string address, int age, string mobile, string type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.type = type;
        }

        private string name;
        private string address;
        private int age;
        private string mobile;
        private string type;

        public override string ToString()
        {
            return string.Format("Name: {0}, Address: {1}, Age: {2}, Mobile: {3}, Type: {4}", name, age, address, mobile,
                type.ToString());
        }

    }
}