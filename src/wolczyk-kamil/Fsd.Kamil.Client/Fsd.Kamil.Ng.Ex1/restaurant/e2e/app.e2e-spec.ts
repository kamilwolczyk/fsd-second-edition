import { RestaurantPage } from './app.po';

describe('restaurant App', () => {
  let page: RestaurantPage;

  beforeEach(() => {
    page = new RestaurantPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
