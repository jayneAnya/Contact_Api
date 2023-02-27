using Contact.Core.Interface;
using Contact.Core.Repository;
using Contact.Domain.Configuration;
using Contact.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Contact.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ContactDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("ContactDb"), b => b.MigrationsAssembly("Contact.API")));

            builder.Services.AddScoped<IUserContact, UserContactRepository>();
            builder.Services.AddScoped<IAddress, AddressRepository>();
            builder.Services.AddScoped<IEmail, EmailRepository>();
            builder.Services.AddScoped<IPhoneNumber, PhoneNumberRepository>();

            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            //builder.Services.ResolveDependencies();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

           app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}