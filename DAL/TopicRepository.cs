namespace DAL;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;
using MySql.Data.MySqlClient;
public static class TopicRepository
{

  public static List<Topic> allTopic = JsonSerializer.Deserialize<List<Topic>>(File.ReadAllText("../trainingtopic.json"));


  public static List<Topic> GetAllTopics()
  {
    return allTopic;
  }

  public static Topic GetTopicByFaculty(string Faculty)
  {

    var theTopic = allTopic.First(i => i.Faculty == Faculty);
    return theTopic as Topic;
  }

}
