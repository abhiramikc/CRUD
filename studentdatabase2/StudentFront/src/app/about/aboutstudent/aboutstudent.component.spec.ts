import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutstudentComponent } from './aboutstudent.component';

describe('AboutstudentComponent', () => {
  let component: AboutstudentComponent;
  let fixture: ComponentFixture<AboutstudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AboutstudentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutstudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
