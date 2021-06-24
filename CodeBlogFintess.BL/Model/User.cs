﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFintess.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get;}
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public double Heigth { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">День рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name,
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Проверка условий
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол пользователя не может быть  null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес пользователя не может быть меньше или равен 0", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Рост пользователя не может быть меньше или равен 0", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Heigth = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
