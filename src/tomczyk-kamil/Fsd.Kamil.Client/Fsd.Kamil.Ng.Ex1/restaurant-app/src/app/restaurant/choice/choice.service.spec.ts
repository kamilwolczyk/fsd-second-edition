import { TestBed, inject } from '@angular/core/testing';

import { ChoiceService } from './choice.service';

describe('ChoiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ChoiceService]
    });
  });

  it('should be created', inject([ChoiceService], (service: ChoiceService) => {
    expect(service).toBeTruthy();
  }));
});
