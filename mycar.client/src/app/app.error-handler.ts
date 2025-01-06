import { ErrorHandler, Inject, Injectable, Injector, NgZone } from "@angular/core";
import { ToastrService } from "ngx-toastr";

@Injectable()
export class AppErrorHandler implements ErrorHandler {
  constructor(
    private ngZone:NgZone,
    @Inject(Injector) private readonly injector: Injector
  ) { }

  private get toastrService() {
    return this.injector.get(ToastrService);
  }

  handleError(error: any): void {
    this.ngZone.run(() => {
      this.toastrService.error(
        'An unexpected error happened.',
        'Error',
        {
          timeOut: 5000,
          positionClass: 'toast-top-right'
        }
      );
    });  
  }
}
