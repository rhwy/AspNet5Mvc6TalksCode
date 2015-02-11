namespace Mailbox.Common {
  public delegate string GenerateId();

  public static class IdGenerator
  {
    public static GenerateId Generate {get;set;}
      = ()=> System.Guid.NewGuid().ToString();

    public static string NewId() {
      return Generate();
    }
  }

}

namespace Mailbox.Models {
  using static Mailbox.Common.IdGenerator;

  public struct Message{
    public string Content {get;}
    public string Id {get;}
    public Message(string content) {
      Content = content;
      Id = string.Empty;
      Id = NewId();
    }
  }

  public class MailBox
  {
    public string Name {get;}
    public MailBox(string boxname)
    {
      Name = boxname;
    }

    public PutCommandStatus Put(Message message)
    {
      return PutCommandStatus.Delivered;
    }
  }

  public enum PutCommandStatus {
    Delivered
  }
}
