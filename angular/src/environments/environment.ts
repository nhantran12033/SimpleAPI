import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SimpleAPI',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44345/',
    redirectUri: baseUrl,
    clientId: 'SimpleAPI_App',
    responseType: 'code',
    scope: 'offline_access SimpleAPI',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44345',
      rootNamespace: 'SimpleAPI',
    },
  },
} as Environment;
