﻿namespace ETicaretAPI.Application.RequestParamaters;
public record Pagination
{
    public int Page { get; set; } = 0;
    public int Size { get; set; } = 5;
}
