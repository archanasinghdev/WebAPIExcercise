namespace Application.DTOs
{
    public abstract class BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
