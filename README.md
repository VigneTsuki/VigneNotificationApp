## VigneNotificationApp

<p>Aplica��o para enviar notifica��es para um usu�rio no Windows 10.</p>

### Tecnologias

<ul>
	<li>C# .NET 7.0</li>
	<li>Nuget: Microsoft.Toolkit.Uwp.Notifications</li>
</ul>

### Execu��o

<p>Para gerar o execut�vel basta executar o seguinte comando na pasta ra�z do projeto:</p>

> dotnet publish -c Release -r win-x64 --sc -o ./Executavel -p:PublishSingleFile=true

<p>Com o execut�vel gerado � feito o agendamento de uma tarefa no windows que executa o .exe gerado anteriormente.</p>
<p>A notifica��o do windows utiliza o �cone do projeto que pode ser alterado no arquivo .csproj.</p>
<p>A aplica��o recebe 1 argumento que � o nome do usu�rio que ir� aparecer na notifica��o.</p>