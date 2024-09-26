var level1 = new Level1Handler();
var level2 = new Level2Handler();
var level3 = new Level3Handler();

TicketControl ticketControl = new TicketControl(level1);
ticketControl.AddNextHandler(level2);
ticketControl.AddNextHandler(level3);

ticketControl.ProcessTicket("Problema Simples");
ticketControl.ProcessTicket("Problema Médio");
ticketControl.ProcessTicket("Problema Avançado");
ticketControl.ProcessTicket("Problema Impossível");
