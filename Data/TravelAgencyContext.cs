using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using travel_agency_back.Data.Models;

namespace travel_agency_back.Data
{
    public partial class TravelAgencyContext : DbContext
    {
        public TravelAgencyContext()
        {
        }

        public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<Atraction> Atractions { get; set; } = null!;
        public virtual DbSet<AtractionsPhoto> AtractionsPhotos { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Destiny> Destinies { get; set; } = null!;
        public virtual DbSet<DestinyBuy> DestinyBuys { get; set; } = null!;
        public virtual DbSet<DestinyBuyAtraction> DestinyBuyAtractions { get; set; } = null!;
        public virtual DbSet<DestinyBuyHotel> DestinyBuyHotels { get; set; } = null!;
        public virtual DbSet<DestinyPhoto> DestinyPhotos { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<FlightBuy> FlightBuys { get; set; } = null!;
        public virtual DbSet<FlightBuyItem> FlightBuyItems { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<HotelPhoto> HotelPhotos { get; set; } = null!;
        public virtual DbSet<HotelRoom> HotelRooms { get; set; } = null!;
        public virtual DbSet<Restaurant> Restaurants { get; set; } = null!;
        public virtual DbSet<RestaurantPhoto> RestaurantPhotos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= IGNACIO-PC; Database=TravelAgency;User ID=sa;Password=nachin123;ConnectRetryCount=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("airport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__airport__id_city__2C3393D0");
            });

            modelBuilder.Entity<Atraction>(entity =>
            {
                entity.ToTable("atractions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.IdDestiny).HasColumnName("id_destiny");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdDestinyNavigation)
                    .WithMany(p => p.Atractions)
                    .HasForeignKey(d => d.IdDestiny)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__atraction__id_de__2F10007B");
            });

            modelBuilder.Entity<AtractionsPhoto>(entity =>
            {
                entity.ToTable("atractions_photos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAtraction).HasColumnName("id_atraction");

                entity.Property(e => e.UrlPhoto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_photo");

                entity.HasOne(d => d.IdAtractionNavigation)
                    .WithMany(p => p.AtractionsPhotos)
                    .HasForeignKey(d => d.IdAtraction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__atraction__id_at__5CD6CB2B");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Coin)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("coin");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Photo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("photo");
            });

            modelBuilder.Entity<Destiny>(entity =>
            {
                entity.ToTable("destiny");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Destinies)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny__id_city__29572725");
            });

            modelBuilder.Entity<DestinyBuy>(entity =>
            {
                entity.ToTable("destiny_buy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdDestiny).HasColumnName("id_destiny");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_cost");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.DestinyBuys)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_cu__48CFD27E");

                entity.HasOne(d => d.IdDestinyNavigation)
                    .WithMany(p => p.DestinyBuys)
                    .HasForeignKey(d => d.IdDestiny)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_de__47DBAE45");
            });

            modelBuilder.Entity<DestinyBuyAtraction>(entity =>
            {
                entity.ToTable("destiny_buy_atraction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdActraction).HasColumnName("id_actraction");

                entity.Property(e => e.IdDestinyBuy).HasColumnName("id_destiny_buy");

                entity.HasOne(d => d.IdActractionNavigation)
                    .WithMany(p => p.DestinyBuyAtractions)
                    .HasForeignKey(d => d.IdActraction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_ac__5812160E");

                entity.HasOne(d => d.IdDestinyBuyNavigation)
                    .WithMany(p => p.DestinyBuyAtractions)
                    .HasForeignKey(d => d.IdDestinyBuy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_de__571DF1D5");
            });

            modelBuilder.Entity<DestinyBuyHotel>(entity =>
            {
                entity.ToTable("destiny_buy_hotel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdDestinyBuy).HasColumnName("id_destiny_buy");

                entity.Property(e => e.IdHotelRoom).HasColumnName("id_hotel_room");

                entity.HasOne(d => d.IdDestinyBuyNavigation)
                    .WithMany(p => p.DestinyBuyHotels)
                    .HasForeignKey(d => d.IdDestinyBuy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_de__4CA06362");

                entity.HasOne(d => d.IdHotelRoomNavigation)
                    .WithMany(p => p.DestinyBuyHotels)
                    .HasForeignKey(d => d.IdHotelRoom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_b__id_ho__4BAC3F29");
            });

            modelBuilder.Entity<DestinyPhoto>(entity =>
            {
                entity.ToTable("destiny_photos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDestiny).HasColumnName("id_destiny");

                entity.Property(e => e.UrlPhoto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_photo");

                entity.HasOne(d => d.IdDestinyNavigation)
                    .WithMany(p => p.DestinyPhotos)
                    .HasForeignKey(d => d.IdDestiny)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__destiny_p__id_de__5FB337D6");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("flight");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DepartureCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departure_city");

                entity.Property(e => e.DestinyCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("destiny_city");

                entity.Property(e => e.IdAirport).HasColumnName("id_airport");

                entity.HasOne(d => d.IdAirportNavigation)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.IdAirport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__flight__id_airpo__3A81B327");
            });

            modelBuilder.Entity<FlightBuy>(entity =>
            {
                entity.ToTable("flight_buy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdFlight).HasColumnName("id_flight");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.FlightBuys)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__flight_bu__id_cu__4222D4EF");

                entity.HasOne(d => d.IdFlightNavigation)
                    .WithMany(p => p.FlightBuys)
                    .HasForeignKey(d => d.IdFlight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__flight_bu__id_fl__412EB0B6");
            });

            modelBuilder.Entity<FlightBuyItem>(entity =>
            {
                entity.ToTable("flight_buy_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthdayPassenger)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday_passenger");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdFlightBuy).HasColumnName("id_flight_buy");

                entity.Property(e => e.LastnamePassenger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname_passenger");

                entity.Property(e => e.NamePassenger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_passenger");

                entity.Property(e => e.TicketNumber).HasColumnName("ticket_number");

                entity.HasOne(d => d.IdFlightBuyNavigation)
                    .WithMany(p => p.FlightBuyItems)
                    .HasForeignKey(d => d.IdFlightBuy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__flight_bu__id_fl__44FF419A");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("hotel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.IdDestiny).HasColumnName("id_destiny");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdDestinyNavigation)
                    .WithMany(p => p.Hotels)
                    .HasForeignKey(d => d.IdDestiny)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__hotel__id_destin__31EC6D26");
            });

            modelBuilder.Entity<HotelPhoto>(entity =>
            {
                entity.ToTable("hotel_photos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdHotel).HasColumnName("id_hotel");

                entity.Property(e => e.UrlPhoto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_photo");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.HotelPhotos)
                    .HasForeignKey(d => d.IdHotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__hotel_pho__id_ho__628FA481");
            });

            modelBuilder.Entity<HotelRoom>(entity =>
            {
                entity.ToTable("hotel_room");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cost");

                entity.Property(e => e.IdHotel).HasColumnName("id_hotel");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.QuantityRoms).HasColumnName("quantity_roms");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.HotelRooms)
                    .HasForeignKey(d => d.IdHotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__hotel_roo__id_ho__37A5467C");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("restaurant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.IdDestiny).HasColumnName("id_destiny");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdDestinyNavigation)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.IdDestiny)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__restauran__id_de__34C8D9D1");
            });

            modelBuilder.Entity<RestaurantPhoto>(entity =>
            {
                entity.ToTable("restaurant_photos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdRestaurant).HasColumnName("id_restaurant");

                entity.Property(e => e.UrlPhoto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_photo");

                entity.HasOne(d => d.IdRestaurantNavigation)
                    .WithMany(p => p.RestaurantPhotos)
                    .HasForeignKey(d => d.IdRestaurant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__restauran__id_re__656C112C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
