import { Component } from '@angular/core';
import { RouterOutlet, RouterLink } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'SaborAi';
  
  toggleMobileMenu() {
    const menu = document.querySelector('.navbar-menu');
    const toggle = document.querySelector('.navbar-toggle');
    
    if (menu && toggle) {
      menu.classList.toggle('active');
      toggle.classList.toggle('active');
    }
  }
}
