using Microsoft.SqlServer.Server;

namespace DDL_TRIGGER_LAB
{
    public class Trigger_PrintTableNameOnInsert
    {
        [SqlTrigger(Name = "PrintTableNameOnInsert", Event = "FOR INSERT")]
        public static void PrintTableNameOnInsert()
        {
            SqlPipe pipe = SqlContext.Pipe;
            pipe.Send("Я добрый CRL триггер. Я рад, что меня вызвали ^_^");
        }
    }
}
