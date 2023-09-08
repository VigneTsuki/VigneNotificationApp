using Microsoft.Toolkit.Uwp.Notifications;

if(args.Length > 0)
{
    new ToastContentBuilder()
    .AddText("Olá " + args[0] + "!")
    .AddText("Arruma a coluna!")
    .AddInlineImage(new Uri("C:\\TarefasAgendadas\\appNotificationImage.png"))
    .AddButton(new ToastButton()
        .SetContent("Ta bão!")
        .AddArgument("action", "taBao"))
    .AddAudio(new ToastAudio
    {
        Src = new Uri("ms-winsoundevent:Notification.Looping.Alarm7"),
        Silent = false,
        Loop = false
    })
    .Show(toast =>
    {
        toast.ExpirationTime = DateTime.Now.AddSeconds(15);
    });

    ToastNotificationManagerCompat.OnActivated += toastArgs =>
    {
        if (toastArgs.Argument == "taBao" || toastArgs.Argument == "")
            ToastNotificationManagerCompat.History.Clear();
    };

    Thread.Sleep(16000);
}