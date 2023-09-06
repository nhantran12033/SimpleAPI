import type { InformationDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class BusinessTripService {
  apiName = 'Default';
  

  create = (dto: InformationDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, InformationDto>({
      method: 'POST',
      url: '/api/app/business-trip',
      body: dto,
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, InformationDto[]>({
      method: 'GET',
      url: '/api/app/business-trip',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
