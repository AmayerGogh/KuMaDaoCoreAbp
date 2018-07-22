import { Component, Input, Output, EventEmitter } from '@angular/core';
import * as moment from 'moment';

@Component({
    selector: 'count-down',
    templateUrl: './count-down.component.html'
})
export class CountDownComponent {

    @Input() config: any;

    /**
     * 目标时间
     */
    @Input()
    set target(value: number | Date) {
        this.config = {
            template: `$!h!:$!m!:$!s!`,
            stopTime: typeof value === 'number' ? moment().add(value, 's').valueOf() : moment(value).valueOf()
        };
    }

    @Output() begin = new EventEmitter();
    @Output() notify = new EventEmitter<number>();
    @Output() end = new EventEmitter();

    _start() {
        this.begin.emit();
    }

    _notify(time: number) {
        this.notify.emit(time);
    }

    _finished() {
        this.end.emit();
    }
}
