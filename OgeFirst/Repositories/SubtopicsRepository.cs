using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OgeFirst.Repositories
{
    public class SubtopicsRepository : RepositoryBase
    {
        public static List<SubtopicBasicDTO> GetBasics()
        {
            return (List<SubtopicBasicDTO>)Perform(ReadBasics);
        }

        public static SubtopicDTO GetOne(int id)
        {
            return (SubtopicDTO)Perform(ReadFull, id);
        }

        private static SubtopicDTO ReadFull(SqlConnection connection, int subtopicId)
        {
            var reader = new SqlCommand("SELECT * FROM Subtopics WHERE Id = " + subtopicId, connection).ExecuteReader();
            reader.Read();
            return new SubtopicDTO
            {
                SubtopicId = Convert.ToInt32(reader["Id"]),
                Name = Convert.ToString(reader["Name"]),
                Description = Convert.ToString(reader["Description"]),
                TopicId = Convert.ToInt32(reader["TopicId"]),
                VideoLink = Convert.ToString(reader["VideoLink"]),
                Order = Convert.ToInt32(reader["Sort"]),
            };
        }

        private static List<SubtopicBasicDTO> ReadBasics(SqlConnection connection)
        {
            var reader = GetReader("SELECT Id, Name, TopicId, Sort FROM Subtopics", connection);
            List<SubtopicBasicDTO> result = new List<SubtopicBasicDTO>();
            while (reader.Read())
            {
                result.Add(new SubtopicBasicDTO
                {
                    SubtopicId = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    TopicId = Convert.ToInt32(reader["TopicId"]),
                    Order = Convert.ToInt32(reader["Sort"])
                });
            }

            return result;
        }
    }
}