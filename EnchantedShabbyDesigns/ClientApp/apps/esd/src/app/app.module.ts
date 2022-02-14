import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { APP_INITIALIZER, ErrorHandler, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent, AppErrorHandler, AppHttpInterceptor, ROUTES } from '.';
import { AppLayoutsModule } from './layouts';
import { AppSettingsService } from './settings';

@NgModule({
  bootstrap: [AppComponent],
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(ROUTES),
    AppLayoutsModule,
  ],
  providers: [
    { provide: ErrorHandler, useClass: AppErrorHandler },
    {
      provide: APP_INITIALIZER,
      useFactory: (_: AppSettingsService) => () => {},
      multi: true,
    },
    { provide: HTTP_INTERCEPTORS, useClass: AppHttpInterceptor, multi: true },
  ],
})
export class AppModule {}
