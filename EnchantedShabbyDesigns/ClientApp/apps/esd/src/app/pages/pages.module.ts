import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { AppMainModule } from './main';
import { AppSigninModule } from './signin';

@NgModule({
  declarations: [],
  imports: [CommonModule, AppMainModule, AppSigninModule],
})
export class AppPagesModule {}
