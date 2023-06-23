using System;

namespace LocacaoLaboratorio
{
    internal class TratarErro
    {
        internal int GetId(Exception ex)
        {
            if (ex.Data.Contains("Id"))
                return (int)ex.Data["Id"];
            return -1;
        }
    }
}
