﻿using quizal.models;
using quizal.models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace quizal.Common.ViewModels
{
    public class QuizViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public string QuizLogoUrl { get; set; }

        public ICollection<QuestionViewModel> QuizQuestions { get; set; }

        public List<AnswersBindingModel> Answers { get; set; }

        public UserResult Result { get; set; }
    }
}
