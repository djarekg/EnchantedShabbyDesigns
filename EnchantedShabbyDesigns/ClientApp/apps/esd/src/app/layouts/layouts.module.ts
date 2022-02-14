import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { RouterModule } from '@angular/router';
import { AppFooterComponent } from './footer/footer.component';
import { AppHeaderComponent } from './header/header.component';
import { AppLayoutMainComponent } from './layout-main/layout-main.component';
import { AppLayoutComponent } from './layout/layout.component';
import { AppNavComponent } from './nav/nav.component';

@NgModule({
  declarations: [
    AppFooterComponent,
    AppHeaderComponent,
    AppLayoutComponent,
    AppLayoutMainComponent,
    AppNavComponent,
  ],
  imports: [
    FormsModule,
    RouterModule,
    MatButtonModule,
    MatIconModule,
    MatSidenavModule,
  ],
  exports: [AppLayoutMainComponent],
})
export class AppLayoutsModule {}
