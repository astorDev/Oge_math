using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OgeFirst.Repositories
{
    public class QuestionsRepository : RepositoryBase
    {
        public static string GetTextForQuestion(int id)
        {
            return Perform(ReadTextForQuestion, id).ToString();
        }

        public static double GetAnswerForQuestion(int id)
        {
            return Convert.ToDouble(Perform(ReadAnswerForQuestion, id));
        }

        public static List<QuestionDTO> GetQuestionsForSubtopic(int id)
        {
            return (List<QuestionDTO>)Perform(ReadQuestionsForSubtopic, id);
        }

        private static List<QuestionDTO> ReadQuestionsForSubtopic(SqlConnection connection, int id)
        {
            List<QuestionDTO> result = new List<QuestionDTO>();
            var reader = GetReader("SELECT Id, Text FROM Questions WHERE SubtopicId = " + id.ToString(), connection);

            while (reader.Read())
            {
                result.Add(new QuestionDTO
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Text = Convert.ToString(reader["Text"])
                });
            }

            return result;
        }

        private static object ReadAnswerForQuestion(SqlConnection connection, int id)
        {
            var scalar = new SqlCommand("SELECT Answer FROM Questions WHERE Id = " + id.ToString(), connection).ExecuteScalar();
            return scalar;
        }

        private static string ReadTextForQuestion(SqlConnection connection, int id)
        {
            var scalar = new SqlCommand("SELECT Text FROM Questions WHERE Id = " + id.ToString(), connection).ExecuteScalar();
            return Convert.ToString(scalar);
        }
    }
}