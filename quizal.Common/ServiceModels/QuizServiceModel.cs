﻿using quizal.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace quizal.Common.ServiceModels
{
    public class QuizServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string QuizLogoUrl { get; set; }

        public ICollection<Question> QuizQuestions { get; set; }


        public List<AnswersServiceModel> Answers { get; set; }

        public UserResult Result { get; set; }
    }
}
