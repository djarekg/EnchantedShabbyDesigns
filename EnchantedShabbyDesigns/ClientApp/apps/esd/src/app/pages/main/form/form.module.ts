import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { AppFormComponent } from './form.component';

const ROUTES: Routes = [{ path: '', component: AppFormComponent }];

@NgModule({
  declarations: [AppFormComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(ROUTES),
  ],
})
export class AppFormModule {}
