﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker2020.ViewModels
{
    public class EditCommentViewModel
    {

        public int ID { get; set; }

        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public int AdminID { get; set; }

        public string AdminFirstName { get; set; }

        
        public string Date { get; set; }

       
        public string CommentBody { get; set; }

       
        public int BugID { get; set; }



        public EditCommentViewModel()
        {
        }
    }
}
