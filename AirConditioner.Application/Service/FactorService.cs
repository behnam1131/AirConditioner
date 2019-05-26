﻿using AirConditioner.Core.Dtos;
using AirConditioner.Core.Interfaces;
using AirConditioner.Core.Models;
using AirConditioner.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirConditioner.Application.Service
{
    public class FactorService : IFactorService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IFactorPieceService _factorPieceService;
        private readonly IFactorWorkService _factorWorkService;
        public FactorService(ApplicationDbContext dbContext, IFactorPieceService factorPieceService, IFactorWorkService factorWorkService)
        {
            _dbContext = dbContext;
            _factorPieceService = factorPieceService;
            _factorWorkService = factorWorkService;
        }


        public List<FactorDto> GetAll()
        {
            var list = _dbContext.Factors.Select(e => new FactorDto
            {
                Id = e.Id,
                ChangeDateTime = e.ChangeDateTime,
                DateFa = e.DateFa,
                Time = e.Time,
                Code = e.Code,
                Comment = e.Comment,

                CustomerId = e.CustomerId,
                CustomerName = e.Customer.Name,

                EngineVolumeId = e.EngineVolumeId,
                EngineVolumeName = e.EngineVolume.Name,

                UserAssistantId = e.UserAssistantId,
                UserAssistantName = e.UserAssistant.Name,

                UserExpertId = e.UserExpertId,
                UserExpertName = e.UserExpert.Name,

                UserOperatorId = e.UserOperatorId,
                UserOperatorName = e.UserOperator.Name,

                UserTechnicianId = e.UserTechnicianId,
                UserTechnicianName = e.UserTechnician.Name,

                AirConditionerModelId = e.AirConditionerModelId,
                AirConditionerModelName = e.AirConditionerModel.Name,

                FactorPieceDtos = e.FactorPiecePrices.Select(q => new FactorPieceDto
                {
                    Id = q.Id,
                    Comment = q.Comment,
                    IsChange = q.IsChange,
                    FactorId = q.FactorId,
                    PriceOne = q.PriceOne,
                    PriceTotal = q.PriceTotal,
                    PieceId = q.PieceId,
                    PieceName=q.Piece.Name,
                    Value = q.Value,

                }).ToList(),
                FactorWorkDtos = e.FactorWorks.Select(q => new FactorWorkDto
                {
                    Id = q.Id,
                    Comment = q.Comment,
                    Price = q.Price,
                    WorkId = q.WorkId,
                    WorkName=q.Work.Name

                }).ToList()

            }).ToList();

            return list;
        }


        public FactorDto GetById(int factorId)
        {
            var factor = _dbContext.Factors
                .Where(e => e.Id == factorId)
                .Select(e => new FactorDto
                {
                    Id = e.Id,
                    ChangeDateTime = e.ChangeDateTime,
                    DateFa = e.DateFa,
                    Time = e.Time,
                    Code = e.Code,
                    Comment = e.Comment,

                    CustomerId = e.CustomerId,
                    CustomerName = e.Customer.Name,

                    EngineVolumeId = e.EngineVolumeId,
                    EngineVolumeName = e.EngineVolume.Name,

                    UserAssistantId = e.UserAssistantId,
                    UserAssistantName = e.UserAssistant.Name,

                    UserExpertId = e.UserExpertId,
                    UserExpertName = e.UserExpert.Name,

                    UserOperatorId = e.UserOperatorId,
                    UserOperatorName = e.UserOperator.Name,

                    UserTechnicianId = e.UserTechnicianId,
                    UserTechnicianName = e.UserTechnician.Name,

                    AirConditionerModelId = e.AirConditionerModelId,
                    AirConditionerModelName = e.AirConditionerModel.Name,

                    FactorPieceDtos = e.FactorPiecePrices.Select(q => new FactorPieceDto
                    {
                        Id = q.Id,
                        Comment = q.Comment,
                        IsChange = q.IsChange,
                        FactorId = q.FactorId,
                        PriceOne = q.PriceOne,
                        PriceTotal = q.PriceTotal,
                        PieceId = q.PieceId,
                        PieceName = q.Piece.Name,
                        Value = q.Value,

                    }).ToList(),
                    FactorWorkDtos = e.FactorWorks.Select(q => new FactorWorkDto
                    {
                        Id = q.Id,
                        Comment = q.Comment,
                        Price = q.Price,
                        WorkId = q.WorkId,
                        WorkName = q.Work.Name

                    }).ToList()

                }).FirstOrDefault();

            return factor;
        }

        public bool Add(FactorDto factorDto)
        {
            Factor  factor = new Factor
            {
                ChangeDateTime = factorDto.ChangeDateTime,
                DateFa = factorDto.DateFa,
                Time = factorDto.Time,
                Code = factorDto.Code,
                Comment = factorDto.Comment,

                CustomerId = factorDto.CustomerId,                
                EngineVolumeId = factorDto.EngineVolumeId,               
                UserAssistantId = factorDto.UserAssistantId,                
                UserExpertId = factorDto.UserExpertId,                
                UserOperatorId = factorDto.UserOperatorId,                
                UserTechnicianId = factorDto.UserTechnicianId,
                AirConditionerModelId = factorDto.AirConditionerModelId,                
            };
            try
            {
                _dbContext.Factors.Add(factor);
                _dbContext.SaveChanges();

                factorDto.FactorPieceDtos.ForEach(e =>
                {
                    e.FactorId = factor.Id;
                });
                factorDto.FactorWorkDtos.ForEach(e =>
                {
                    e.FactorId = factor.Id;
                });

                _factorPieceService.Add(factorDto.FactorPieceDtos);
                _factorWorkService.Add(factorDto.FactorWorkDtos);
               
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}