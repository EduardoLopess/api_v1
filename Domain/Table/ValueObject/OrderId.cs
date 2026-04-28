namespace Domain.Table.ValueObject
{
    public record OrderId
    {
        public int Value { get; }

        public OrderId (int value)
        {
            if (value <= 0) 
                throw new ArgumentException("Id inválido.");
            
            Value = value;
        }

 
    }
}

