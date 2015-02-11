//https://github.com/rhwy/AspNet5Mvc6TalksCode
using static System.Console;
using Xunit;
using NFluent;
using System;
using Mailbox.Models;
using Mailbox.Common;

public class MessageTests
{
  [Fact] protected void
  a_message_must_have_default_properties_on_ctor()
  {
    IdGenerator.Generate = ()=> "1234";
    var message = new Message("hello");

    Check.That(message.Id).IsNotNull();
    Check.That(message.Id)
      .IsEqualTo("1234");


  }

}
public class MailBoxTests
{
  [Fact] public void
  should_create_a_named_mailbox()
  {
    var mailBox = new MailBox("rui");
    Check.That(mailBox.Name).IsEqualTo("rui");
  }

  [Fact] public void
  should_store_a_message_in_a_named_box()
  {
    var message = new Message("hello");
    var mailbox = new MailBox("rui");
    var actionResult = mailbox.Put(message);
    Check.That(actionResult)
      .IsEqualTo(PutCommandStatus.Delivered);
  }

  [Fact] public void
  should_get_a_message_in_a_named_box()
  {
    var message = new Message("hello");
    var mailbox = new MailBox("rui");
    var actionResult = mailbox.Put(message);
    Check.That(actionResult)
      .IsEqualTo(PutCommandStatus.Delivered);
  }

}
