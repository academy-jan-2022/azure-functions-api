using System;

public struct NumberResponse
{
    public int Number;
    public Guid GUID;

    public NumberResponse(int number, Guid GUID) {
        this.Number = number;
        this.GUID = GUID;

    }

} 