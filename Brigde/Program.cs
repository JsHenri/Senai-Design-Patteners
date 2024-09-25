// Criando uma TV e um controle remoto básico para a TV
TV tv = new TV();
UniversalRemoteControl remoteForTV = new UniversalRemoteControl(tv);

// Usando o controle remoto para a TV
remoteForTV.TurnOn();
remoteForTV.SetVolume(10);
remoteForTV.TurnOff();

Console.WriteLine();

// Criando um Rádio e um controle remoto básico para o Rádio
Radio radio = new Radio();
UniversalRemoteControl remoteForRadio = new UniversalRemoteControl(radio);

// Usando o controle remoto para o Rádio
remoteForRadio.TurnOn();
remoteForRadio.SetVolume(5);
remoteForRadio.TurnOff();