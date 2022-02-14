import { Component } from '@angular/core';
import { AppAuthService } from '../../services';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
})
export class AppNavComponent {
  opened: boolean | undefined;

  constructor(private readonly appAuthService: AppAuthService) {}

  signout() {
    this.appAuthService.signout();
  }
}
