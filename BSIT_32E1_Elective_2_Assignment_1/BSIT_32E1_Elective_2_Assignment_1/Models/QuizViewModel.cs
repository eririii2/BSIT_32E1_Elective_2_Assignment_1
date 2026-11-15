using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E1_Elective_2_Assignment_1.Models
{
    public class QuizViewModel
    {
        public string StudentName { get; set; } = "Leisbeth Ann B. Ramones";
        public string ClassName { get; set; } = "BSIT";
        public string Section { get; set; } = "32E1";

        public List<Question> Questions { get; set; } = new List<Question>();
    }

    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; } = "";

        public List<string> Choices { get; set; } = new List<string>();

        public string SelectedAnswer { get; set; } = "";
    }
}