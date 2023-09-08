## VigneNotificationApp

<p>Aplicação para enviar notificações para um usuário no Windows 10.</p>

### Tecnologias

<ul>
	<li>C# .NET 7.0</li>
	<li>Nuget: Microsoft.Toolkit.Uwp.Notifications</li>
</ul>

### Execução

<p>Para gerar o executável basta executar o seguinte comando na pasta raíz do projeto:</p>

> dotnet publish -c Release -r win-x64 --sc -o ./Executavel -p:PublishSingleFile=true

<p>Com o executável gerado é feito o agendamento de uma tarefa no windows que executa o .exe gerado anteriormente.</p>
<p>A notificação do windows utiliza o ícone do projeto que pode ser alterado no arquivo .csproj.</p>
<p>A aplicação recebe 1 argumento que é o nome do usuário que irá aparecer na notificação.</p>
<p>A imagem deve ser salva em C:/TarefasAgendadas/appNotificationImage.png</p>
### Exemplo Notificação

![exemplo](https://github.com/VigneTsuki/VigneNotificationApp/assets/80185960/31754461-26e7-4f42-994a-62a5db75739b)
