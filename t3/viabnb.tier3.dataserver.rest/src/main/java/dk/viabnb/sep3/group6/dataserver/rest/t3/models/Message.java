package dk.viabnb.sep3.group6.dataserver.rest.t3.models;

import java.time.LocalDateTime;

public class Message
{
  private User sender;
  private User receiver;
  private String Content;
  private LocalDateTime timeSent;

  public Message(User sender, User receiver, String content,
      LocalDateTime timeSent)
  {
    this.sender = sender;
    this.receiver = receiver;
    Content = content;
    this.timeSent = timeSent;
  }

  public User getSender()
  {
    return sender;
  }

  public User getReceiver()
  {
    return receiver;
  }

  public String getContent()
  {
    return Content;
  }

  public LocalDateTime getTimeSent()
  {
    return timeSent;
  }

  public void setSender(User sender)
  {
    this.sender = sender;
  }

  public void setReceiver(User receiver)
  {
    this.receiver = receiver;
  }

  public void setContent(String content)
  {
    Content = content;
  }

  public void setTimeSent(LocalDateTime timeSent)
  {
    this.timeSent = timeSent;
  }
}
