namespace BLL;
using BOL;
using DAL;

public class TopicManager
{
  public static TopicManager _ref = null;

  private TopicManager()
  {

  }

  public static TopicManager GetTopicManager()
  {
    if (_ref == null)
    {
      _ref = new TopicManager();
    }
    return _ref;
  }

  public List<Topic> GetAllTopics()
  {
    List<Topic> topics = TopicRepository.GetAllTopics();
    return topics;
  }

  public Topic GetTopicByFaculty(String Faculty)
  {
    Topic t = TopicRepository.GetTopicByFaculty(Faculty);
    return t;
  }

}
