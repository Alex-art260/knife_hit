using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NotificationSamples;
using System;

public class Notification : MonoBehaviour
{
   [SerializeField] private GameNotificationsManager notificationsManager;
    public int notificationDelay;

    private void Start()
    {
        InitializeNotifications();

        CreateNotification();
    }

    private void InitializeNotifications()
    {
        GameNotificationChannel channel = new GameNotificationChannel("tutorial", "Mobile Notifications Tutorial", "Just a notification");
        notificationsManager.Initialize(channel);
    }

    public void OnTimeInput(string text)
    {
        if (int.TryParse(text, out int sec))
            notificationDelay = sec;
    }

    public void CreateNotification()
    {
        CreateNotification("Уведомление",
            "Это, чего так долго не заходишь, мы грустим...",
            DateTime.Now.AddHours(notificationDelay));
    }

    private void CreateNotification(string title, string body, DateTime time)
    {
        IGameNotification notification = notificationsManager.CreateNotification();
        if(notification != null)
        {
            notification.Title = title;
            notification.Body = body;
            notification.DeliveryTime = time;
            notificationsManager.ScheduleNotification(notification);
        }
    }
}
