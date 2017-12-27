using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using Mapster;
using MicroBenchmarking.Entities;
using System;


namespace MicroBenchmarking
{
    [MinColumn, MaxColumn, MedianColumn, RankColumn]
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    public class Mappers
    {
        private static IMapper _Mapper;
        private static int ItCount = 1000;

        public Mappers()
        {
            _Mapper = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, CustomerViewItem>(); }).CreateMapper();

        }
        private Customer GetNewCustomer()
        {
            return new Customer()
            {
                DateOfBirth = new DateTime(1983, 4, 23),
                FirstName = "Arturo",
                LastName = "Alee",
                NumberOfOrders = new Random().Next()
            };
        }

        [Benchmark]
        public void Manual()
        {
            Customer _nc = GetNewCustomer();
            for (int i = 0; i < ItCount; i++)
            {
                CustomerViewItem customerViewItem = new CustomerViewItem()
                {
                    FirstName = _nc.FirstName,
                    LastName = _nc.LastName,
                    DateOfBirth = _nc.DateOfBirth,
                    NumberOfOrders = _nc.NumberOfOrders
                };

            }

        }

        [Benchmark]
        public void AutoMapper()
        {
            Customer _nc = GetNewCustomer();
            for (int i = 0; i < ItCount; i++)
            {
                CustomerViewItem customerViewItem = _Mapper.Map<Customer, CustomerViewItem>(_nc);
            }
        }


        [Benchmark]
        public void Agile()
        {
            Customer _nc = GetNewCustomer();
            for (int i = 0; i < ItCount; i++)
            {
                CustomerViewItem customerViewItem = AgileObjects.AgileMapper.Mapper.Map(_nc).ToANew<CustomerViewItem>();
            }
        }

        [Benchmark]
        public void Mapster()
        {
            Customer _nc = GetNewCustomer();
            for (int i = 0; i < ItCount; i++)
            {
                CustomerViewItem customerViewItem = _nc.Adapt<CustomerViewItem>();
            }
        }
    }
}

