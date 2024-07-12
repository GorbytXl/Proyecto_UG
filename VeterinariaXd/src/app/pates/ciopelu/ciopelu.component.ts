import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-ciopelu',
  templateUrl: './ciopelu.component.html',
  styleUrls: ['./ciopelu.component.css']
})
export class CiopeluComponent implements OnInit {
  username: string = '';

  constructor(private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.username = params['username'];
    });
  }

  navigateToPeluqueria(): void {
    this.router.navigate(['/peluqueria']);
  }

  navigateToMedica(): void {
    this.router.navigate(['/medicina']);
  }
}
