﻿namespace RoomReservationWPF.Models.Employees
{
    using System;
    using System.Runtime.Serialization;
    using System.Text;

    using RoomReservationWPF.Common;
    using RoomReservationWPF.Contracts;
    using RoomReservationWPF.Exceptions;

    [Serializable]
    public class Manager : RegularEmployee, IRegularEmployee, ISerializable
    {
        private int yearsOfExperience;

        public Manager(string name, string title, Location location, int yearsOfExperience)
            : base(name, title, location)
        {
            this.YearsOfExperience = yearsOfExperience;
        }

        public Manager(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.YearsOfExperience = (int)info.GetValue("YearsExperience", typeof(int));
        }

        public Manager(string csvStr)
            :base(csvStr)
        {
            string[] data = csvStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            this.YearsOfExperience = int.Parse(data[3]);
        }

        public override EmployeePriorityType Priority
        {
            get
            {
                return EmployeePriorityType.Medium;
            }
        }

        public int YearsOfExperience
        {
            get
            {
                return this.yearsOfExperience;
            }

            private set
            {
                if (value < 0)
                {
                    throw new DateExceptions("The experience of a manager should be a positive number.");
                }

                this.yearsOfExperience = value;
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("YearsExperience", this.YearsOfExperience, typeof(int));
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.AppendLine(string.Format("Experience: {0} years", this.YearsOfExperience));
            return builder.ToString();
        }
    }
}
