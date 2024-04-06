using Application.Features.Brands.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQuery : IRequest<BrandListModel> //Burada BrandistModel yerine bir dto da kullanılabilirdi fakat o zaman yalnızca Brand listesi ile alakalı bilgiler aktarılabilirdi. Burada BranListModel
                                                              //oluşturulmasının sebebi Brand listesi ile beraber sayfalamanın da kullanılmak istenmesidir.
    {
        public PageRequest PageRequest { get; set; }

        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, BrandListModel>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<BrandListModel> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Brand> brands = await _brandRepository.GetListAsync(index : request.PageRequest.Page, size: request.PageRequest.PageSize);
                BrandListModel mappedBrandListModel = _mapper.Map<BrandListModel>(brands);

                return mappedBrandListModel;
            }
        }
    }
}
