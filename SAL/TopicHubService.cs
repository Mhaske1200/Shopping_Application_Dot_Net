namespace SAL;
using BLL;
using BOL;
public class TopicHubService
{
  public List<Topic> GetAllTopic()
  {
    TopicManager theTopicManager = TopicManager.GetTopicManager();
    List<Topic> Topics = theTopicManager.GetAllTopics();
    return Topics;
  }

  public Topic GetTopicById(string Faculty)
  {
    TopicManager theTopicManager = TopicManager.GetTopicManager();
    Topic t = theTopicManager.GetTopicByFaculty(Faculty);

    return t;
  }

}
