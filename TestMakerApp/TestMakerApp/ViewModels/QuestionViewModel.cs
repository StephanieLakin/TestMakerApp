using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TestMakerApp.ViewModels
{
    public class QuestionViewModel
    {
        #region Cob=nstructor
        public QuestionViewModel()
        {
              
        }
        #endregion


        #region Properties
        public int Id { get; set; }
        public int QuizID { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        [DefaultValue(0)]
        public int Type { get; set; }
        [DefaultValue(0)]
        public int Flags { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        #endregion
    }
}
