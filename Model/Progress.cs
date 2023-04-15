﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Employee_Training_Portal.Model
{
    public class Progress
    {

        [Key]
        public int progressId { get; set; } //primary key for accessing progress table

        [ForeignKey("employeeID")]//foreign key to access score based on employee ID 
        public int score { get; set; }//default score set to 0 

    }
}
