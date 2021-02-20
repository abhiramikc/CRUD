import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetstudentListComponent } from './getstudent-list.component';

describe('GetstudentListComponent', () => {
  let component: GetstudentListComponent;
  let fixture: ComponentFixture<GetstudentListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetstudentListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetstudentListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
