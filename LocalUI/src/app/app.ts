import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DashBoard } from './dash-board/dash-board';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, DashBoard],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('LocalUI');
}
