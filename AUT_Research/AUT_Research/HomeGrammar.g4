grammar HomeGrammar;

prog: command (';' command)* ';'? ;

command
    : TASK TASK_DEVICE                                       # TaskCommand
    | I_AM FEELING                                           # FeelingCommand
    | IT_IS TIME_OF_DAY                                      # TimeCommand
    | TURN DEVICE STATE                                      # TurnDeviceCommand
    | UPDATE TIME_OF_DAY (DEVICE STATE | TASK_DEVICE STATE)   # UpdateDeviceCommand
    ;

TURN: 'turn';
STATE: 'on' | 'off';
UPDATE: 'update';
TASK: 'start';
I_AM: 'i am';
IT_IS: 'it is';

DEVICE: 'light' | 'heater' | 'airco' | 'doors';
TASK_DEVICE: 'coffeemachine' | 'dishwasher' | 'washingmachine';
FEELING: 'cold' | 'hot' | 'thirsty';
TIME_OF_DAY: 'morning' | 'afternoon' | 'evening' | 'night';

WS: [ \t\r\n]+ -> skip;
