using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace SimpleAPI.BusinessTrip
{
    [Authorize]
    public class BusinessTripService: ApplicationService, IBusinessTripAppService
    {
        private readonly IRepository<Informations, Guid> _informationRespository;
        private readonly IRepository<Expenses, Guid> _expensesRepository;
        private readonly IRepository<Items, Guid> _itemsRepository;
        public BusinessTripService(IRepository<Informations, Guid> information,
            IRepository<Expenses, Guid> expensesRepository,
            IRepository<Items, Guid> itemsRepository)
        {
            _informationRespository = information;
            _expensesRepository = expensesRepository;
            _itemsRepository = itemsRepository;
        }

        public async Task<InformationDto> CreateAsync(InformationDto dto)
        {
          
            Informations information = new Informations
            {
                OperaterName = dto.OperaterName,
                VerifierName = dto.VerifierName,
                VerifierUsername = dto.VerifierUsername,
                BusinessType = dto.BusinessType,
                Notes = dto.Notes,
                RequestDate = dto.RequestDate,
                RequestNumber = dto.RequestNumber,
                ExpenseCode = dto.ExpenseCode,
                Department = dto.Department,
                LegalEntity = dto.LegalEntity,

                ExpenseDetail = new List<Expenses>()
            };

            foreach (var expenseDto in dto.ExpenseDetail)
            {
                Expenses expenses = new Expenses
                {
                    Id = expenseDto.Id,
                    InformationsId = dto.Id,
                    Purpose = expenseDto.Purpose,
                    Destination = expenseDto.Destination,
                    CheckinTime = expenseDto.CheckinTime,
                    CheckoutTime = expenseDto.CheckoutTime,
                    TotalNights = expenseDto.TotalNights,
                    
                    ItemDetail = new List<Items>()
                };
                foreach(var itemsDto in expenseDto.ItemDetail)
                {
                    Items items = new Items
                    {
                        Id = itemsDto.Id,
                        ExpensesId = expenseDto.Id,
                        Item = itemsDto.Item,
                        Specification = itemsDto.Specification,
                        OriginalCurrency = itemsDto.OriginalCurrency,
                        OriginalUnit = itemsDto.OriginalUnit,
                        Volume = itemsDto.Volume,
                        OriginalAmount = itemsDto.OriginalAmount,
                        EquivalentInVND = itemsDto.EquivalentInVND,
                        Notes = itemsDto.Notes
                    };
                    expenses.ItemDetail.Add(items);
                }
                information.ExpenseDetail.Add(expenses);
            }

            await _informationRespository.InsertAsync(information);
            var create = new InformationDto
            {
                Id = information.Id,
                OperaterName = information.OperaterName,
                VerifierName = information.VerifierName,
                VerifierUsername = information.VerifierUsername,
                BusinessType = information.BusinessType,
                Notes = information.Notes,
                RequestDate = information.RequestDate,
                RequestNumber = information.RequestNumber,
                Department = information.Department,
                ExpenseCode = information.ExpenseCode,
                LegalEntity = information.LegalEntity,
                ExpenseDetail = information.ExpenseDetail.Select(te => new ExpenseDto
                {
                    Id = te.Id,   
                    InformationsId = information.Id,
                    Purpose = te.Purpose,
                    Destination = te.Destination,
                    CheckinTime = te.CheckinTime,
                    CheckoutTime = te.CheckoutTime,
                    TotalNights = te.TotalNights,
                    ItemDetail = te.ItemDetail.Select(it => new ItemDto
                    {
                        Id = it.Id,
                        ExpensesId = te.Id,
                        Item = it.Item,
                        Specification = it.Specification,
                        OriginalCurrency = it.OriginalCurrency,
                        OriginalUnit = it.OriginalUnit,
                        Volume = it.Volume,
                        OriginalAmount = it.OriginalAmount,
                        EquivalentInVND = it.EquivalentInVND,
                        Notes = it.Notes
                    }).ToList()
                }).ToList()
            };
            return create;

        }

        public async Task<List<InformationDto>> GetListAsync()
        {
            var item = await _itemsRepository.GetListAsync();
            var expenses = await _expensesRepository.GetListAsync();
            var information = await _informationRespository.GetListAsync();
            return information.Select(e => new InformationDto
            {
                Id = e.Id,
                OperaterName = e.OperaterName,
                VerifierName = e.VerifierName,
                VerifierUsername = e.VerifierUsername,
                BusinessType = e.BusinessType,
                Notes = e.Notes,
                RequestDate = e.RequestDate,
                RequestNumber = e.RequestNumber,
                Department = e.Department,
                ExpenseCode = e.ExpenseCode,
                LegalEntity = e.LegalEntity,
                ExpenseDetail = expenses.Where(te => te.InformationsId == e.Id).Select(te => new ExpenseDto
                {
                    Id = te.Id,
                    InformationsId = te.InformationsId,
                    Purpose = te.Purpose,
                    Destination = te.Destination,
                    CheckinTime = te.CheckinTime,
                    CheckoutTime = te.CheckoutTime,
                    TotalNights = te.TotalNights,
                    TotalAmount = te.TotalAmount,
                    ItemDetail = item.Where(items => items.ExpensesId == te.Id).Select(items => new ItemDto
                    {
                        Item = items.Item,
                        Specification = items.Specification,
                        OriginalCurrency = items.OriginalCurrency,
                        OriginalUnit = items.OriginalUnit,
                        OriginalAmount = items.OriginalAmount,
                        EquivalentInVND = items.EquivalentInVND,
                        Notes= items.Notes,
                        Volume= items.Volume,
                        ExpensesId = items.ExpensesId,
                        Id = items.Id
                    }).ToList()
                }).ToList()
            }).ToList();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _informationRespository.DeleteAsync(id);
        }
    }
}
